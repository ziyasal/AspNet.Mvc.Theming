AspNet.Mvc.Theming
======================

Enables implementing themes for ASP.NET MVC.

* [Nuget Package - AspNet.Mvc.Theming](https://www.nuget.org/packages/AspNet.Mvc.Theming/)

To install AspNet.Mvc.Theming, 
```bash
Install-Package AspNet.Mvc.Theming
```
How to use;
-----------------------------

  Create [**Themes**](https://github.com/ziyasal/AspNet.Mvc.Theming/tree/master/src/AspNet.Mvc.Theming.Sample/Themes) (or what you want) folder and put your themes to folder and initialize [**ThemeManager**](https://github.com/ziyasal/AspNet.Mvc.Theming/blob/master/src/AspNet.Mvc.Theming/ThemeManager.cs) to use this folder to apply theme and set default theme;

```csharp
 public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
        
           //Omitted for brevity..

            ThemeManager.Instance.Configure(config => {
                config.ThemeDirectory = "~/Themes";
                config.DefaultTheme = "Other";
            });
        }
    }
```

Put [**Theme**](https://github.com/ziyasal/AspNet.Mvc.Theming/blob/master/src/AspNet.Mvc.Theming/Attributes/ThemeAttribute.cs) attribute to your controller to use theme you want.
```csharp
 [Theme("Default")]
    public class WorkController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View(new WorkModel
            {
                Content = "Hello World!"
            });
        }

    }
```
