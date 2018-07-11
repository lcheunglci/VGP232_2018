//#pragma once

#ifndef INCLUDED_CAR_H
#define INCLUDED_CAR_H

class Car
{
public:

	int GetWheels();
	void SetWheels(int value);

	Car();
	~Car();

private:
	int wheels;
	char* color;
	int doors;


};

#endif // !INCLUDED_CAR_H
