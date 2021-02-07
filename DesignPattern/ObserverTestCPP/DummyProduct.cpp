#include "DummyProduct.h"

void DummyProduct::ChangePrice(float price)
{
    NotifyPrice(price);
}

void DummyProduct::ChangeNumber(int number)
{
    NotifyNumber(number);
}
