#pragma once
#include <iostream>
#include <string>
#include "IObserver.h"

class Shop : IObserver
{
	//Name of the Shop
	std::string name;
    float price;
	int number;

public:
	Shop(std::string n); 
    void UpdatePrice(float price);      
	void UpdateNumber(int number);
};
