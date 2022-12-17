// See https://aka.ms/new-console-template for more information
using MeasureDuringDevelopment;

var peopleList = new List<Person>();

PeopleManager.AddPeople(peopleList);
PeopleManager.MeasureAges(peopleList);