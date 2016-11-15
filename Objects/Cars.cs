using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _name;
    private string _make;
    private string _model;
    private int _year;
    private float _price;
    private string _color;
    private static string _input;

    private static List<Car> _cars = new List<Car> {};
    private static List<Car> _matchingCars = new List<Car> {};


    public Car (string name, string make, string model, int year, float price, string color)
    {
      _name = name;
      _make = make;
      _model = model;
      _year = year;
      _price = price;
      _color = color;

    }

    public string GetName()
    {
      return _name;
    }

    public void SetMake(string Make)
    {
      _make = Make;
    }

    public string GetMake()
    {
      return _make;
    }

    public void SetModel(string Model)
    {
      _model = Model;
    }

    public string GetModel()
    {
      return _model;
    }
    public void SetYear(int Year)
    {
      _year = Year;
    }

    public int GetYear()
    {
      return _year;
    }
    public void SetPrice(float Price)
    {
      _price = Price;
    }

    public float GetPrice()
    {
      return _price;
    }
    public void SetColor(string Color)
    {
      _color = Color;
    }

    public string GetColor()
    {
      return _color;
    }

    public void Save()
    {
      _cars.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _cars;
    }

    public static string GetInput()
    {
      return _input;
    }

    public static void SetInput(string Input)
    {
      _input = Input;
    }

    public static List<Car> Filter()
    {
      foreach (Car c in _cars)
      {
        if (c._name == _input)
        {
          _matchingCars.Add(c);
        }
      };
      return _matchingCars;
    }
  }
}
