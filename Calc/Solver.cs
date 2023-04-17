using System;
using System.Linq.Expressions;

public class Solver : ISolve 
{
    private string accumulated ="";
    private double total = 0.0;

    public string Accumulated
    {
        get
        {
            return this.accumulated;
        }
        set
        {
            this.accumulated = value;
        }
    }
    public double Total
    {
        get
        {
            return this.total;
        }
        set
        {
            this.total = value;
        }
    }

    public Solver()
	{
	}

    private bool isOperator(char c)//function to check if a character is an operator (doesnt do minus sign as i handle that differently
    {
        return c == '/' || c == '*' || c == '+' || c == '%';
    }

    private string getEndNumber(string sub) 
    {
        //function to get a number from a string. Gets the last number. used to get a number before an operator
        string num = "";
        for(int i = sub.Length-1; i>=0; i--)
        {
            if (isOperator(sub[i])) break;
            if (num.StartsWith('-')) break;
            num = sub[i] + num;
        }
        return num;
    }

    private string getBeginningNumber(string sub)
    {
        //function to get a number from a string. Gets the first number. used to get a number after an operator
        string num = "";
        for (int i = 0; i < sub.Length; i++)
        {
            if (isOperator(sub[i]) && i != 0) break;
            if (sub[i] == '-' && num.Length>0) break;
            num += sub[i];
        }
        return num;
    }

    private double convertPossibleNegativetoDouble(string s)
    { //Convert.ToDouble cant handle negative numbers, which i want it to. so i made a wrapper for the built in function
        if (s.StartsWith('-'))
        {
            return Convert.ToDouble(s.Substring(1, s.Length - 1))*-1;
        }
        else if (s.Length>0)
        {
            return Convert.ToDouble(s);
        }
        else
        {
            return 0.0;
        }
    }

    private void ComputeOperator(char op)
    { //takes an operator and does the appropriate operations to it by getting both sides of th eoperator and doing the operator
        while (Accumulated.Contains(op) && Accumulated.LastIndexOf(op) != 0)
        {
            int i = Accumulated.IndexOf(op);
            if (i == 0 && op == '-')
            {
                string temp = Accumulated.Substring(1, Accumulated.Length - 1);
                i = temp.IndexOf(op)+1;
            }
            if (Accumulated[i] == op)
            {
                string firstNumber = getEndNumber(Accumulated.Substring(0, i));
                string secondNumber = getBeginningNumber(Accumulated.Substring(i + 1, Accumulated.Length - (i + 1)));
                string result = "";

                double firstNumberWord = (convertPossibleNegativetoDouble(firstNumber));
                double secondNumberWord = (convertPossibleNegativetoDouble(secondNumber));


                switch (op)
                {
                    case '*':
                        result = (firstNumberWord * secondNumberWord).ToString();
                        break;
                    case '/':
                        result = (firstNumberWord / secondNumberWord).ToString();
                        break;
                    case '+':
                        result = (firstNumberWord + secondNumberWord).ToString();
                        break;
                    case '-':
                        result = (firstNumberWord - secondNumberWord).ToString();
                        break;
                    case '%':
                        if (secondNumber.Length != 0)
                            result = ((firstNumberWord / 100.0) * secondNumberWord).ToString();
                        else
                            result = (firstNumberWord / 100.0).ToString();
                        break;
                }

                string secondWord;
                if ((i + secondNumber.Length + 1) >= Accumulated.Length) secondWord = "";
                else secondWord = Accumulated.Substring(i + secondNumber.Length + 1, Accumulated.Length - (i + secondNumber.Length + 1));

                string firstWord;
                if ((i - firstNumber.Length) <= 0) firstWord = "";
                else firstWord = Accumulated.Substring(0, i - firstNumber.Length);



                Accumulated = firstWord + result + secondWord;

                //Console.WriteLine($"LeftNum: {firstNumber}, RightWord: {secondNumber}, Result: {result}\nfirstWord: {firstWord}, secondWord: {secondWord}, Accumulated: {Accumulated}");
            }
        }
    }
    

    public void Accumulate(string s)
    {
        Accumulated = s;
    }
    public void Clear()
    {
        Accumulated = "";
    }
    public double Solve()
    {
        
        ComputeOperator('*');
        ComputeOperator('/');
        ComputeOperator('%');
        ComputeOperator('+');
        ComputeOperator('-');

        return convertPossibleNegativetoDouble(Accumulated);
    }
}


