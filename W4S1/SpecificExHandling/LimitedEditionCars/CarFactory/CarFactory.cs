


class CarFactory
{
    public int Limited;
    public CarFactory(int amount)
    {
        this.Limited = amount;
    }

    public LimitedEditionCar? ProduceLimitedEditionCar()
    {   

        if (LimitedEditionCar.Counter <= Limited)
        {
            return new LimitedEditionCar();
        }
        
        else
        {   
            
            return null;
        }
    }

   
}

