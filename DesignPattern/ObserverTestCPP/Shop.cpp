#include "Shop.h"

Shop::Shop(std::string name)
{
    this->name = name;
}

void Shop::UpdatePrice(float price)
{
    this->price = price;

    //Lets print on console just to test the working
	std::cout << "Price at "<< name << " is now "<< price << "\n";
}

void Shop::UpdateNumber(int number)
{
    this->number = number;

    //Lets print on console just to test the working
    std::cout << "Number at " << name << " is now " << number << "\n";
}