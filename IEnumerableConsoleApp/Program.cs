using System;

namespace InterfacePractice
{
    // Создаем два интерфейса, описывающих абстрактные методы 
    // арифметических операций и операций Sqrt и Sqr
    interface IArithmeticOperation
    {
        int Addition();
        int Substraction();
        int Multiplication();
        int Division();
    }

    interface IRealizeArithmeticOperation
    {
        int RealizeVol_1(int x);
        int RealizeVol_2(int x);
    }

    class FirstRealize : IArithmeticOperation
    {
        private int valueX;
        private int valueY;

        public int x
        {
            set { valueX = value;}
            get { return valueX; }
        }

        public int y
        {
            set { valueY = value; }
            get { return valueY; }
        }

        public FirstRealize(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int Addition()
        {
            throw new NotImplementedException();
        }

        public int Substraction()
        {
            throw new NotImplementedException();
        }

        public int Multiplication()
        {
            throw new NotImplementedException();
        }

        public int Division()
        {
            throw new NotImplementedException();
        }
    }
}

