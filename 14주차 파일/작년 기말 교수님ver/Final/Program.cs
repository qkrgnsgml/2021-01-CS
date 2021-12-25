using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static List<Product> productlist = new List<Product>();
        static List<Sale> salelist = new List<Sale>();
        static string path = "C:\\Fin20190000";
        static string fileProduct = "product.txt";
        static string fileSale = "sale.txt";

        static string[] menus =
        {
            "A. 상품 정보 입력",
            "B. 상품 정보 수정",
            "C. 판매 입력",
            "D. 통계",
            "",
            "Q. 종료",
        };

        static void Menu()
        {
            foreach (var menu in menus)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("--------------------------");
            Console.Write(">");
        }

        static void Main(string[] args)
        {

            OpenDataList();

            while (true)
            {
                Menu();
                var inMenu = Console.ReadLine().Trim().ToUpper();

                if (inMenu == "Q")
                {
                    return;
                }


                switch (inMenu)
                {
                    case "A":
                        InsertProduct();
                        break;

                    case "B":
                        UpdateProduct();
                        break;

                    case "C":
                        InsertSale();
                        break;

                    case "D":
                        ViewData();
                        break;

                }
                Console.WriteLine();
            }
        }

        private static void OpenDataList()
        {
            if (false == Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filename = string.Empty;

            //product.txt
            filename = Path.Combine(path, fileProduct);
            if (File.Exists(filename))
            {
                using (var sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        string data = sr.ReadLine(); //record
                        string[] splitdata = data.Split(',');

                        if (splitdata.Length == 5)
                        {
                            try
                            {
                                var number = int.Parse(splitdata[0]);
                                var name = splitdata[1];
                                var price = int.Parse(splitdata[2]);
                                var stock = int.Parse(splitdata[3]);
                                var discount = double.Parse(splitdata[4]);

                                productlist.Add(new Product(number, name, stock, price, discount));//복구
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }

            //sale.txt
            filename = Path.Combine(path, fileSale);
            if (File.Exists(filename))
            {
                using (var sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        var data = sr.ReadLine(); //record
                        string[] splitdata = data.Split(',');

                        if (splitdata.Length == 5)
                        {
                            int number = int.Parse(splitdata[0]);
                            int prodnsumber = int.Parse(splitdata[1]);
                            int count = int.Parse(splitdata[3]);
                            int price = int.Parse(splitdata[4]);


                            var year = int.Parse(splitdata[2].Substring(0, 4));
                            var month = int.Parse(splitdata[2].Substring(4, 2));
                            var day = int.Parse(splitdata[2].Substring(6, 2));

                            var date = new DateTime(year, month, day);

                            salelist.Add(new Sale(number, prodnsumber, date, count, price));

                        }
                    }
                }
            }
        }

        private static void ViewData()
        {
            for (int i = 0; i < productlist.Count; i++)
            {
                int totalcnt = 0;
                int totalprice = 0;

                for (int j = 0; j < salelist.Count; j++)
                {
                    if (salelist[j].ProdNumber == productlist[i].Number)
                    {
                        totalcnt += salelist[j].Count;
                        totalprice += salelist[j].Price;
                    }
                }

                Console.WriteLine($"총수량: {totalcnt,10}개 총판매액: {totalprice,10}원 [{productlist[i].Name}]");
            }
        }

        private static void InsertSale()
        {
            string name;
            int count;
            Product searchproduct = null;

            try
            {
                Console.Write("상품명:");
                name = Console.ReadLine();

                searchproduct = productlist.FirstOrDefault(m => m.Name == name);

                if (searchproduct == null)
                {
                    Console.WriteLine("상품정보 없음");
                    return;
                }

                Console.WriteLine($"현재 재고:{searchproduct.StockCount}");
                Console.WriteLine($"30개 이상 구매시 할인율:{(int)(searchproduct.DiscountRate * 100)}%");

                Console.Write("판매 수량:");
                count = int.Parse(Console.ReadLine());

                var sale = new Sale(salelist.Count, searchproduct.Number, DateTime.Now, count, searchproduct.Sale(count));
                salelist.Add(sale);

                Console.WriteLine($"판매번호:{sale.Number} 상품이름:{searchproduct.Name} 판매일자:{sale.Date.ToString("yyyy-MM-dd")} 판매수량:{sale.Count} 판매금액:{sale.Price}");


                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }

                var filename = Path.Combine(path, fileSale);
                using (var sw = new StreamWriter(new FileStream(filename, FileMode.Append), Encoding.UTF8))
                {
                    sw.WriteLine($"{sale.Number.ToString("000000")},{sale.ProdNumber.ToString("000000")},{sale.Date.ToString("yyyyMMdd")},{sale.Count.ToString("00000000")},{sale.Price.ToString("0000000000")}");
                }

                //prodduct 재고수량...
                filename = Path.Combine(path, fileProduct);

                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        //한줄씾ㄱ읽으면서,원하는제품을찾기
                        int pos = 0;
                        while (!sr.EndOfStream)
                        {
                            var data = sr.ReadLine();

                            if (0 == data.IndexOf(searchproduct.Number.ToString("000000")))
                            {
                                var seekpos = pos + Encoding.UTF8.GetByteCount(data) - Encoding.UTF8.GetByteCount("000000,00.00");

                                fs.Seek(seekpos, SeekOrigin.Begin);

                                var wdata = Encoding.UTF8.GetBytes(searchproduct.StockCount.ToString("000000"));
                                fs.Write(wdata, 0, wdata.Length);

                                break;
                            }

                            pos += Encoding.UTF8.GetByteCount(data) + Environment.NewLine.Length;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }

        private static void UpdateProduct()
        {
            string name;
            string inputsel;
            int count;
            double discount;
            Product searchproduct = null;

            try
            {
                Console.Write("상품명:");
                name = Console.ReadLine();

                searchproduct = productlist.FirstOrDefault(m => m.Name == name);

                //for(int i=0; i < productlist.Count; i++)
                //{
                //    if(productlist[i].Name == name)
                //    {
                //        searchproduct = productlist[i];
                //        break;
                //    }
                //}

                if (searchproduct == null)
                {
                    Console.WriteLine("상품정보 없음");
                    return;
                }

                Console.WriteLine($"현재 재고:{searchproduct.StockCount}");
                Console.WriteLine($"30개 이상 구매시 할인율:{(int)(searchproduct.DiscountRate * 100)}%");

                Console.Write("추가 입고 수량 입력(1) 할인율 수정(2):");
                inputsel = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(inputsel))
                {
                    return;
                }

                if (inputsel == "1")
                {
                    try
                    {
                        //재고수량 변경
                        Console.Write("추가 재고 수량:");
                        count = int.Parse(Console.ReadLine());
                        searchproduct.AddStockCout(count);
                        Console.WriteLine($"현재 재고:{searchproduct.StockCount}");

                        var filename = Path.Combine(path, fileProduct);

                        using (var fs = new FileStream(filename, FileMode.Open))
                        {
                            using (var sr = new StreamReader(fs, Encoding.UTF8))
                            {
                                //한줄씾ㄱ읽으면서,원하는제품을찾기
                                int pos = 0;
                                while (!sr.EndOfStream)
                                {
                                    var data = sr.ReadLine();

                                    if (0 == data.IndexOf(searchproduct.Number.ToString("000000")))
                                    {
                                        var seekpos = pos + Encoding.UTF8.GetByteCount(data) - Encoding.UTF8.GetByteCount("000000,00.00");

                                        fs.Seek(seekpos, SeekOrigin.Begin);

                                        var wdata = Encoding.UTF8.GetBytes(searchproduct.StockCount.ToString("000000"));
                                        fs.Write(wdata, 0, wdata.Length);

                                        break;
                                    }

                                    pos += Encoding.UTF8.GetByteCount(data) + Environment.NewLine.Length;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
                else if (inputsel == "2")
                {
                    try
                    {
                        //할인율 변경
                        Console.Write("수정 할인율(예:10% ->0.1입력):");
                        discount = double.Parse(Console.ReadLine());
                        searchproduct.DiscountRate = discount;
                        Console.WriteLine($"변경 30개 이상 구매시 할인율:{(int)(searchproduct.DiscountRate * 100)}");


                        var filename = Path.Combine(path, fileProduct);

                        using (var fs = new FileStream(filename, FileMode.Open))
                        {
                            using(var sr = new StreamReader(fs, Encoding.UTF8))
                            {
                                //한줄씾ㄱ읽으면서,원하는제품을찾기
                                int pos = 0;
                                while (!sr.EndOfStream)
                                {
                                    var data = sr.ReadLine();

                                    if( 0 == data.IndexOf(searchproduct.Number.ToString("000000")))
                                    {
                                        var seekpos = pos + Encoding.UTF8.GetByteCount(data) - Encoding.UTF8.GetByteCount("00.00");

                                        fs.Seek(seekpos, SeekOrigin.Begin);

                                        var wdata = Encoding.UTF8.GetBytes(searchproduct.DiscountRate.ToString("00.00"));
                                        fs.Write(wdata, 0, wdata.Length);

                                        break;
                                    }

                                    pos += Encoding.UTF8.GetByteCount(data) + Environment.NewLine.Length;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }

        static void InsertProduct()
        {
            string name;
            int price;
            int count;
            double discount;

            try
            {
                Console.Write("상품명:");
                name = Console.ReadLine();

                Console.Write("단가:");
                price = int.Parse(Console.ReadLine());

                Console.Write("초기수량:");
                count = int.Parse(Console.ReadLine());

                Console.Write("30개 이상 구매시 할인율 (예: 10% -> 0.1 입력):");
                discount = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("입력 형식에 문제가 있습니다.");
                return;
            }


            var prod = new Product(productlist.Count, name, count, price, discount);
            productlist.Add(prod);

            Console.WriteLine($"상품번호:{prod.Number} 이름:{prod.Name} 단가:{prod.UnitPrice} 재고수량:{prod.StockCount} 할인율:{(int)(prod.DiscountRate * 100)}%");



            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            var filename = Path.Combine(path, fileProduct);

            using (var sw = new StreamWriter(new FileStream(filename, FileMode.Append), Encoding.UTF8))
            {
                sw.WriteLine($"{prod.Number.ToString("000000")},{prod.Name},{prod.UnitPrice.ToString("000000")},{ prod.StockCount.ToString("000000")},{prod.DiscountRate.ToString("00.00")}");
            }

        }
    }
}
