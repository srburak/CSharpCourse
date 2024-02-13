
IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker()
};

foreach (var eat in eats)
{
    eat.Eat();
}


interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface IGetSalary
{
    void GetSalary();
}

class Manager : IWorker, IEat, IGetSalary
{
    public void Work()
    {
        throw new System.NotImplementedException();
    }

    public void Eat()
    {
        throw new System.NotImplementedException();
    }

    public void GetSalary()
    {
        throw new System.NotImplementedException();
    }
}


class Worker : IWorker, IEat, IGetSalary
{
    public void Work()
    {
        throw new System.NotImplementedException();
    }

    public void Eat()
    {
        throw new System.NotImplementedException();
    }

    public void GetSalary()
    {
        throw new System.NotImplementedException();
    }
}


class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}