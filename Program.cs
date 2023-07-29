using System;

class Program
{
    public static void DisplayReceipt(Receipt receipt)
    {
        Console.WriteLine("\n---------- Receipt ----------");
        Console.Writeline("Rhy`s Smartphone Store");

        
        Console.WriteLine($"Receipt Number: {receipt.ReceiptNumber}");
        Console.WriteLine($"Date and Time: {receipt.DateTime}");
        Console.WriteLine($"Mode of Payment: {receipt.MOP}");
        Console.WriteLine("\n--- Purchased Smartphone ---");
        Console.WriteLine(receipt.ChosenSmartphone);
        Console.WriteLine($"Quantity: {receipt.Quantity}");
        Console.WriteLine($"Total Price: P{receipt.GetTotalPrice()}");
        Console.WriteLine("Thank you for purchasing from us, we hope to see you again!");
    }

    static void Main(string[] args)
    {
        OrderedBrand[] smartphones = new OrderedBrand[]
        {
            new OrderedBrand("Apple", "iPhone 14 Pro Max", "iOS 15", "Red", "Apple A16 Bionic (4 nm)", 8, 256, 6.7, 69990),
            new OrderedBrand("Apple", "iPhone 13 Pro", "iOS 14", "Blue", "Apple A15 Bionic (5 nm)", 6, 256, 6.1, 59990),
            new OrderedBrand("Apple", "iPhone 12 Pro", "iOS 14", "Yellow", "Apple A14 Bionic (5 nm)",6, 128, 6.1, 39990),
            new OrderedBrand("Samsung", "Galaxy S21 Ultra", "Android 11", "Red", "Snapdragon 888 5G (5 nm)", 12, 256, 6.8, 41973),
            new OrderedBrand("Samsung", "Galaxy Note 20", "Android 10", "Blue", "Snapdragon 865 5G+ (7 nm+)", 8, 256, 6.7, 49999),
            new OrderedBrand("Samsung", "Galaxy A22 5G", "Android 11", "Yellow", "Mediatek MT6833 Dimensity 700 (7 nm)", 8, 128, 6.8, 25999),
            new OrderedBrand("Xiaomi", "Mi 11 Ultra", "Android 11", "Red", "Snapdragon 888 5G (5 nm)", 12, 256, 6.81, 36364),
            new OrderedBrand("Xiaomi", "Redmi Note 10 Pro", "Android 11", "Blue", "Snapdragon 732G (8 nm)", 6, 128, 6.67, 15999),
            new OrderedBrand("Xiaomi", "Redmi Note 9", "Android 10", "Yellow", "Mediatek MT6769Z Helio G85 (12nm)", 6, 128, 6.56, 11999),
            new OrderedBrand("Huawei", "Mate 40 Pro", "Android 11", "Red", "Kirin 9000 5G (5 nm)", 8, 256, 6.76, 49350),
            new OrderedBrand("Huawei", "P30 Pro", "Android 10", "Blue", "Kirin 980 (7 nm)", 8, 256, 6.58, 59999),
            new OrderedBrand("Huawei", "P60 Pro", "Android 13", "Yellow", "Snapdragon 8+ Gen 1 4G (4 nm)", 8, 256, 6.58, 69999),
            new OrderedBrand("Realme", "Realme 11 Pro", "Android 13","Red", "Mediatek MT6877V Dimensity 7050 (6 nm)", 8, 256, 6.7, 136450),
            new OrderedBrand("Realme", "Realme Narzo N53", "Android 13", "Blue", "Unisoc Tiger T612 (12 nm)", 6, 128, 6.74,12500),
            new OrderedBrand("Realme", "Realme GT Neo5 SE", "Android 13", "Yellow", "Snapdragon 7+ Gen 2 (4 nm)", 16, 512, 6.74,16445),
            new OrderedBrand("Oppo", "Reno 10 Pro", "Android 13", "Red", "Snapdragon 778G 5G (6 nm)", 12, 256, 6.7, 30699),
            new OrderedBrand("Oppo", "Reno 8 ", "Android 13", "Blue", "Mediatek MT6893Z Dimensity 1300 (6 nm)", 12, 256, 6.4, 16421),
            new OrderedBrand("Oppo", "Find X6 Pro", "Android 13", "Yellow", "Snapdragon 8 Gen 2 (4 nm)", 16, 512, 6.82, 51177),
            new OrderedBrand("LG", "LG Velvet", "Android 10", "Red", "Snapdragon 765G 5G (7 nm)", 8, 128, 6.8, 15000),
            new OrderedBrand("LG", "LG V30+", "Android 7", "Blue", "Snapdragon 835 (10 nm)", 4, 128, 6.0, 12990),
            new OrderedBrand("LG", "LG G7 ThinQ", "Android 10", "Yellow", "Snapdragon 845 (10 nm)", 4, 64, 6.1, 15990),
            };
        Console.WriteLine("Good Day User! Welcome to Rhy's Smartphone Store");

        bool exit = false;
        int receiptNumber = 879604867;

        while (!exit)
        {
            Console.WriteLine("\nPlease enter your preferred color (or type 'exit' to quit):");
            string color = Console.ReadLine();

            if (color.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nThank you for visiting Rhy's Smartphone Store. Have a great day!");
                break;
            }


            Console.WriteLine("Based on your preferred color, Here`s the smartphone brands that you would like:");
            Console.WriteLine("1. Apple");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. Xiaomi");
            Console.WriteLine("4. Huawei");
            Console.WriteLine("5. Realme");
            Console.WriteLine("6. Oppo");
            Console.WriteLine("7. LG");
            Console.WriteLine("8. Exit");

            int brandChoice = int.Parse(Console.ReadLine());

            if (brandChoice >= 1 && brandChoice <= 7)
            {
                string selectedBrand = "";
                switch (brandChoice)
                {
                    case 1:
                        selectedBrand = "Apple";
                        break;
                    case 2:
                        selectedBrand = "Samsung";
                        break;
                    case 3:
                        selectedBrand = "Xiaomi";
                        break;
                    case 4:
                        selectedBrand = "Huawei";
                        break;
                    case 5:
                        selectedBrand = "Realme";
                        break;
                    case 6:
                        selectedBrand = "Oppo";
                        break;
                    case 7:
                        selectedBrand = "LG";
                        break;
                }

                Console.WriteLine($"\nHere are the available {selectedBrand} smartphones with your preferred color '{color}':");

                int i = 1;
                int modelChoice = -1;
                bool foundPreferredColor = false;

                for (int j = 0; j < smartphones.Length; j++)
                {
                    var smartphone = smartphones[j];
                    if (smartphone.Brand == selectedBrand && smartphone.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{i}. {smartphone.Model}");
                        i++;
                        foundPreferredColor = true;
                    }
                }

                if (!foundPreferredColor)
                {
                    Console.WriteLine($"\nSorry buddy, There's no available {selectedBrand} smartphone with your preferred color '{color}'.");
                }
                else
                {
                    Console.WriteLine("\nPlease choose which smartphone that would satisfy you:");
                    modelChoice = int.Parse(Console.ReadLine());
                    i = 1;
                    for (int j = 0; j < smartphones.Length; j++)
                    {
                        var smartphone = smartphones[j];
                        if (smartphone.Brand == selectedBrand && smartphone.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                        {
                            if (i == modelChoice)
                            {
                                modelChoice = j;
                                break;
                            }
                            i++;
                        }
                    }

                    if (modelChoice >= 0 && modelChoice < smartphones.Length)
                    {
                        Console.WriteLine("Enter the quantity:");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nHere are the specifications of your chosen phone:");
                        var chosenSmartphone = smartphones[modelChoice];
                        Console.WriteLine(chosenSmartphone);
                        Console.WriteLine($"\nTotal Price for {quantity} unit(s): P{chosenSmartphone.GetTotalPrice(quantity)}");


                        Console.WriteLine("\nPlease choose a payment method:");
                        Console.WriteLine("1. Cash");
                        Console.WriteLine("2. GCash");
                        Console.WriteLine("3. PayMaya");
                        Console.WriteLine("4. Credit Card");
                        int paymentChoice = int.Parse(Console.ReadLine());

                        string paymentMethod = "";
                        switch (paymentChoice)
                        {
                            case 1:
                                paymentMethod = "Cash";
                                break;
                            case 2:
                                paymentMethod = "GCash";
                                break;
                            case 3:
                                paymentMethod = "PayMaya";
                                break;
                            case 4:
                                paymentMethod = "Credit Card";
                                break;
                            default:
                                Console.WriteLine("\nInvalid payment method choice.");
                                continue;
                        }

                        Console.WriteLine($"Please proceed to the counter for your payment using '{paymentMethod}' and your receipt, Thank you!");

                        Receipt receipt = new Receipt(receiptNumber, paymentMethod, DateTime.Now, chosenSmartphone, quantity);
                        DisplayReceipt(receipt);


                        receiptNumber++;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid model choice.");
                    }
                }
            }
            else if (brandChoice == 8)
            {
                Console.WriteLine("\nThank you user, see us again!");
                exit = true;
            }
            else
            {
                Console.WriteLine("\nInvalid brand choice.");
            }
        }
    }
}
