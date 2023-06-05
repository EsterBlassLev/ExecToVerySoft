// See https://aka.ms/new-console-template for more information
using execVerySoft;
        Cat c = new Cat(true, true, 0, 4);
        Dog d = new Dog(true, false, 1, 4);
        Frog f = new Frog(true, false, 0, 4);
        Console.WriteLine("c number of legs"+c.getNumberOfLegs());
        Console.WriteLine("c say hello");
        c.sayHello();
        c.sayHello(2);
        Console.WriteLine("d number of legs" + d.getNumberOfLegs());
        Console.WriteLine("d say hello");
        d.sayHello();
        d.sayHello(2);

        Console.WriteLine("d number of legs" + f.getNumberOfLegs);
        Console.WriteLine("d say hello");
        f.sayHello(2);
        f.hasLaysEggs();
        f.hasGills();


