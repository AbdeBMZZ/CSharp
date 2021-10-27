using System;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Complexe c1 = new Complexe();
            Complexe c2 = new Complexe();


            c1.SetReel(12);
            c1.SetImg(10);

            c2.SetReel(12);
            c2.SetImg(10);


            if (c1.Equals(c2))
            {
                Console.WriteLine("yes eqyall");
            }

            String s = (String)c2;

            Console.WriteLine(s);


        }

    }
}




class Complexe
{
    private float reel;
    private float img;

    public float GetReel()
    {
        return this.reel;
    }

    public void SetReel(float reel)
    {
        this.reel = reel;
    }
    public float GetImg()
    {
        return this.img;
    }
    public void SetImg(float img)
    {
        this.img = img;
    }

    public override bool Equals(Object obj)
    {
        Complexe c= (Complexe) obj;

        return (reel==c.GetReel() && img==c.GetImg());
    }



    public override int GetHashCode()
    {
        return base.GetHashCode();
    }


    public static explicit operator String(Complexe c1)
    {
        return c1.GetReel() + " + i*" + c1.GetImg();
    }

    public override string ToString()
    {
        return "reel: " + this.reel + "\nimaginaire: " + this.img;
    }


    //comparing two complexes
    public static bool operator !=(Complexe c1, Complexe c2) 
    {
        return !(c1.Equals(c2));
    }

    public static bool operator ==(Complexe c1, Complexe c2) => (c1.Equals(c2));


    //comparing complexe with float
    public static bool operator !=(Complexe c1, float n)
    {
        return !(c1.GetReel() == n && c1.GetImg() == 0);
    }

    public static bool operator ==(Complexe c1, float n) => !(c1!=n);



    public static Complexe operator +(Complexe c1, Complexe c2)
    {
        Complexe clx = new Complexe();
        clx.SetReel(c1.GetReel() + c2.GetReel());
        clx.SetImg(c1.GetImg() + c2.GetImg());

        return clx;
    }
    public static Complexe operator -(Complexe c1, Complexe c2)
    {
        Complexe clx = new Complexe();
        clx.SetReel(c1.GetReel() - c2.GetReel());
        clx.SetImg(c1.GetImg() - c2.GetImg());

        return clx;
    }

    public static Complexe operator * (Complexe c1, Complexe c2)
    {
        Complexe clx = new Complexe();
        clx.SetReel(c1.GetReel() * c2.GetReel());
        clx.SetImg(c1.GetImg() * c2.GetImg());

        return clx;
    }

    public static bool operator >(Complexe c1, Complexe c2)
    {
        return (c1.GetReel() > c2.GetReel() && c1.GetImg() > c2.GetImg());
    }
    public static bool operator <(Complexe c1, Complexe c2)
    {
        return (c1.GetReel() < c2.GetReel() && c1.GetImg() < c2.GetImg());
    }


    public static bool operator >=(Complexe c1, Complexe c2)
    {
        return (c1.GetReel() >= c2.GetReel() && c1.GetImg() >= c2.GetImg());
    }
    public static bool operator <=(Complexe c1, Complexe c2)
    {
        return (c1.GetReel() <= c2.GetReel() && c1.GetImg() <= c2.GetImg());
    }
}