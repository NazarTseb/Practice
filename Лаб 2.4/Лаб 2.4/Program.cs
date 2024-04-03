using System;


class Button
{
    public void Press()
    {
        Console.WriteLine("Клавіша натиснута.");
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (obj == null  || GetType() != obj.GetType())
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return "Button1";
    }
}



class Pedal
{
    public void Press()
    {
        Console.WriteLine("Педаль натиснута.");
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return "Pedal1";
    }
}


class Piano
{
    private Button[] buttons; 
    private Pedal[] pedals;   

    public Piano(int buttonCount, int pedalCount)
    {
        buttons = new Button[buttonCount];
        pedals = new Pedal[pedalCount];
        InitializeButtons();
        InitializePedals();
    }

    
    private void InitializeButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = new Button();
        }
    }

    
    private void InitializePedals()
    {
        for (int i = 0; i < pedals.Length; i++)
        {
            pedals[i] = new Pedal();
        }
    }

    
    public void Tune()
    {
        Console.WriteLine("Піаніно налаштовано.");
    }

    
    public void Play()
    {
        Console.WriteLine("Гра на піаніно.");
    }

    
    public void PressButton(int buttonIndex)
    {
        if (buttonIndex >= 0 && buttonIndex < buttons.Length)
        {
            buttons[buttonIndex].Press();
        }
        else
        {
            Console.WriteLine("Некоректний індекс клавіші.");
        }
    }

    
    public void PressPedal(int pedalIndex)
    {
        if (pedalIndex >= 0 && pedalIndex < pedals.Length)
        {
            pedals[pedalIndex].Press();
        }
        else
        {
            Console.WriteLine("Некоректний індекс педалі.");
        }
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return "Piano1";
    }
}

class Program
{
    static void Main()
    {        
        Piano piano = new Piano(88, 3);
       
        piano.Tune();

        piano.Play();

        piano.PressButton(50);

        piano.PressPedal(1);

        Console.WriteLine(piano);
        Console.WriteLine(piano.Equals(piano));
        Console.WriteLine(piano.GetHashCode());
    }
}

