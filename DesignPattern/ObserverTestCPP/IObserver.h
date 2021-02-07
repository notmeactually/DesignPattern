#pragma once

class IObserver
{
public:
	virtual void UpdatePrice(float price) = 0;
	virtual void UpdateNumber(int number) = 0;
};
