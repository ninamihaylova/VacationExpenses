class VacationExpenses
{
    public static void Main(String[] args)
    {
        string season = Console.ReadLine();
        string accommodationType = Console.ReadLine();
        int countDays = int.Parse(Console.ReadLine());
        int price = 0;
        double discount = 0;


        if (season == "Spring")
        {
            if (accommodationType == "Hotel")
            {
                price = 30;

            }
            else if (accommodationType == "Camping")
            {
                price = 10;

            }

            discount = 20 / 100.00;
        }
        else if (season == "Summer")
        {
            if (accommodationType == "Hotel")
            {
                price = 50;
            }
            else if (accommodationType == "Camping")
            {
                price = 30;
            }
        }
        else if (season == "Autumn")
        {
                if (accommodationType == "Hotel")
                {
                    price = 20;

                }
                else if (accommodationType == "Camping") 
                {
                    price = 15;
                }
                discount = 30 / 100.00;
        }
        else if (season == "Winter")
        {
                if (accommodationType == "Hotel")
                {
                    price = 40;
                }
                else if (accommodationType == "Camping")
                {
                    price = 10;

                }
                discount = 10 / 100.00;
        }

        double finalPrice = countDays * price;
        double finalPriceWithDiscount = finalPrice - (finalPrice * discount );
        Console.WriteLine($"{finalPriceWithDiscount:F2}");
    }
    }



                        
           
    
