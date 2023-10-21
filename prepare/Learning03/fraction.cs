using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {//default number
        _top =  1;
        _bottom = 1;
    } 
    public Fraction(int wholeNumber){//Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
        _top = wholeNumber;// declaro los numeros de arriba y de abajo pero el de abajo se confirma 1 asi se sigue viendo com fraccion. 
        _bottom = 1;//in case a fraction is just over 1 to keep it as a fraction.
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;//normal fraction as a whole.
    }

    public int GetTop(){//getter
        return _top;
    }
    public void SetTop(int top){//setter
        _top = top;
    }
    public int GetBottom(){//getter
        return _bottom;
    }
    public void SetBottom(int bottom){//setter
        _bottom = bottom;
    }
  //now methods to return the presenations. 
    public string GetFraction(){
        string text = $"{_top}/{_bottom}"; //llamar a los originales del la clase, lo que estan primero.
        return text; //recorda hacer una variable y guardarla como texto y return as text.
    }
    public double GetDecimal(){
        return (double)_top / (double)_bottom; // dividirel _top con el _bottom y hacerlo decimal con double between parenthesis.
    }

}