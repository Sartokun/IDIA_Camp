class Program {
    static void Main(string[] args) {
        int Vmax = int.Parse(Console.ReadLine());
        int Vfill = int.Parse(Console.ReadLine());
        int Vdrink = int.Parse(Console.ReadLine());

        int Tdrink = int.Parse(Console.ReadLine());
        int Tfill  = int.Parse(Console.ReadLine());
        int Tday = int.Parse(Console.ReadLine());

        if (Vdrink <= Vmax){
            if (Tday >= Tdrink && Tday >= Tfill){

            }
        }

        //--------------------------------------------------
        /*

        double Left = 0;

        double Balance1 = double.Parse(Console.ReadLine());
        double Balance2  = double.Parse(Console.ReadLine());
        double Balance3 = double.Parse(Console.ReadLine());

        bool y = true;
        do{
            double x = double.Parse(Console.ReadLine());
            if (x > 0){
                if (x <= Balance1){
                    Balance1 -= x;
                }else if (x <= Balance2){
                    Balance2 -= x;
                }else if (x <= Balance3){
                    Balance3 -= x;
                }else{
                    Left += x;
                }
            }else{
                y = false;
            }
        }while(y);

        Console.WriteLine($"Balance 1 : {Balance1},Balance 2 : {Balance2},Balance 3 : {Balance3}");
        if (Left != 0){
            Console.WriteLine($"Left : {Left}");
        }
        */
    }
}