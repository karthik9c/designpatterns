// See https://aka.ms/new-console-template for more information
using Creational.Abstract_Factory;
using Creational.Prototype;

Console.WriteLine("Hello, World!");

// prototype start

ShapeRegistry shapeRegistry = new ShapeRegistry();
shapeRegistry.Add("Red Circle", new Circle(10, "red", "angry"));
shapeRegistry.Add("Black rect", new Rectangle(10, 10, "black", "silent"));


Circle pinkCircle = (Circle)shapeRegistry.Get("Red Circle");
pinkCircle.Color = "pink";
pinkCircle.Name = "girly";
pinkCircle.Render();

Rectangle greenRectangle = (Rectangle)shapeRegistry.Get("Black rect");
greenRectangle.Color = "green";
greenRectangle.Name = "goahead";
greenRectangle.Render();

// prototype end


// abstract factory start

CloudResourceManager azureManager = new CloudResourceManager(new AzureCloudFactory());
azureManager.InsertData("a", "b");
azureManager.Upload("f", new byte[10]);

CloudResourceManager awsManager = new CloudResourceManager(new AWSCloudFactory());
azureManager.InsertData("c", "d");
azureManager.Upload("h", new byte[10]);

// abstract factory end