using System;
//Robert Kajanti
namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläin.KuinkaMonta(); //Metodi tulostaa kaikki Eläin luokkaa käyttävien olioiden määrän
            Monkey.KuinkaMonta(); //Metodi tulostaa kaikki luokkaa käyttävien olioiden määrän
            Dog.KuinkaMonta(); //Metodi tulostaa kaikki koira luokkaa käyttävien olioiden määrän

            Eläin eläin = new Eläin(); //Luo eläin luokkaa käyttävän olion
            Dog.KuinkaMonta();

            eläin.Ääntele(); //Käyttää Ääntele metodia eläin oliolla

            Dog dog = new Dog(); //Luo koira olion
            dog.Ääntele(); //Käyttää ylikirjoitettua ääntele metodia koira oliolla

            Dog Dog2= new Dog();

            Dog Dog23= new Dog();

            Monkey monkey = new Monkey();
            monkey.Ääntele();

            Monkey monkey2 = new Monkey();
            monkey2.Ääntele();
            Monkey monkey3 = new Monkey();
            monkey3.Ääntele();
            Eläin.KuinkaMonta();
            Dog.KuinkaMonta();
            Monkey.KuinkaMonta();
        }
    }
}
