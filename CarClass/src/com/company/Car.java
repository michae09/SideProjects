package com.company;

import java.util.AbstractCollection;
import java.util.ArrayList;
import java.util.Random;

public class Car {

    String year;
    String make;
    String model;
    String color;
    int mileage;
    double price;


    public Car(String year, String make, String model, String color, int mileage, double price)
    {
        this.year = year;
        this.make = make;
        this.model = model;
        this.color = color;
        this.mileage = mileage;
        this.price = price;

    }

    public void setYear(String yr)
    {
        year = yr;
    }

    public void setMake(String mk)
    {
        make = mk;
    }

    public void setModel(String md)
    {
        model = md;
    }

    public void setColor(String cl)
    {
        color = cl;
    }

    public void setMileage(int mil)
    {
        mileage = mil;
    }

    public void setPrice(double pri)
    {
        price = pri;
    }
    public String getYear()
    {
        return year;
    }

    public String getMake()
    {
        return make;
    }

    public String getModel()
    {
        return model;
    }

    public String getColor()
    {
        return color;
    }

    public int getMileage()
    {
        return mileage;
    }

    public double getPrice()
    {
        return price;
    }


    public static void main(String[] args) {

        Car Optima = new Car("2017", "Kia", "Optima", "White", 35000, 19000.00);
        Car Camry = new Car("2015", "Toyota", "Camry", "Red", 55000, 23000.00);
        Car Fusion = new Car("2018", "Ford", "Fusion", "Black", 12000, 26000.00);
        Car Accord = new Car("2014", "Honda", "Accord", "Blue", 67000, 15000.00);
        Car Jetta = new Car("2013", "Volkswagon", "Jetta", "Silver", 75000, 10000.00);

        Car[] carArray = new Car[5];

        carArray[0] = Optima;
        carArray[1] = Camry;
        carArray[2] = Fusion;
        carArray[3] = Accord;
        carArray[4] = Jetta;

        int random1 = (int )(Math.random() * 4);
        int random2 = (int )(Math.random() * 4);
        int random3 = (int )(Math.random() * 4);



        Object randomObj = carArray[random1];
        Object randomObj1 = carArray[random2];
        Object randomObj2 = carArray[random3];

        System.out.println();
        System.out.println("1st Random Choice: " +  ((Car) randomObj).getYear() + " " + ((Car) randomObj).getMake() + " " + ((Car) randomObj).getModel());
        System.out.println("2nd Random Choice: " +  ((Car) randomObj1).getYear() + " " + ((Car) randomObj1).getMake() + " " + ((Car) randomObj1).getModel());
        System.out.println("3rd Random Choice: " +  ((Car) randomObj2).getYear() + " " + ((Car) randomObj2).getMake() + " " + ((Car) randomObj2).getModel());







        System.out.println("----------------------------------------------------");
        System.out.println("Year   " + "  Make   " + "  Model  " + "  Color  " + "  Mileage  " + "  Price  ");
        System.out.println("----------------------------------------------------");
        System.out.println(Optima.getYear() + "    " + Optima.getMake() + "      " + Optima.getModel() + "    " + Optima.getColor() + "    " + Optima.getMileage() + "     " + Optima.getPrice());
        System.out.println(Camry.getYear() + "    " + Camry.getMake() + "   " + Camry.getModel() + "     " + Camry.getColor() + "      " + Camry.getMileage() + "     " + Camry.getPrice());
        System.out.println(Fusion.getYear() + "    " + Fusion.getMake() + "     " + Fusion.getModel() + "    " + Fusion.getColor() + "    " + Fusion.getMileage() + "     " + Fusion.getPrice());
        System.out.println(Accord.getYear() + "    " + Accord.getMake() + "    " + Accord.getModel() + "    " + Accord.getColor() + "     " + Accord.getMileage() + "     " + Accord.getPrice());




    }
}
