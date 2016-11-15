using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["/AddCar.cshtml"];
      Post["/carAdded"] = _ => {
        Car newCar = new Car(Request.Form["name"], Request.Form["make"], Request.Form["model"], Request.Form["year"], Request.Form["price"], Request.Form["color"]);
        newCar.Save();
        return View["/carAdded.cshtml", newCar];
      };
      Get["/carLot"] =_=> {
        List<Car> viewAll = new List<Car> (Car.GetAll());
        return View["/carLot.cshtml", viewAll];
      };
      Post["/carLot"] =_=> {
        Car.SetInput(Request.Form["yourName"]);
        List<Car> viewSome = new List<Car> (Car.Filter());
        return View["/carLot.cshtml", viewSome];
      };
    }
  }
}
