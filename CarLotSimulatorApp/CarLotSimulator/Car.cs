using System;

public class Car
{
	public Car()
	{
		
	}
    public int year { get; set; }
	public string make { get; set; }
	public string model { get; set; }
	public string EngineNoise { get; set; }
	public string HonkNoise { get; set;}
	public bool IsDrivable { get; set; }
	public void MakeEngineNoise(string EngineNoise) 
	{
		Console.WriteLine($"This car's engine makes the following noise: {EngineNoise}");
	}
    public void MakeHonkNoise(string HonkNoise)
    {
		Console.WriteLine($"This car's horn makes the following noise: {HonkNoise}");

    }
}
