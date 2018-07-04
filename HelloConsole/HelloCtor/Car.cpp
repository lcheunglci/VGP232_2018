#include "Car.h"

int Car::GetWheels()
{
	return wheels;
}

void Car::SetWheels(int value)
{
	wheels = value;
}

Car::Car()
	: wheels(0)
	, color(nullptr)
	, doors(0)
{
	// Car a = new Car();
	// a.wheels =0;
	// a.color = nullptr;
	// a.door = 0;
}


