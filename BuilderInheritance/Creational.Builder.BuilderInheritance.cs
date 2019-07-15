using System;

namespace DotNetDesignPatternDemos.Creational.Builder
{
  public class Person
  {
    public string Name;

    public string Position;

    class Builder : PersonInfoBuilder<Builder> { /* degenerate */ }

    public override string ToString()
    {
      return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
  }

  abstract class PersonBuilder<SELF>
    where SELF : PersonBuilder<SELF>
  {
    protected Person person = new Person();

    public Person Build()
    {
      return person;
    }
  }

  class PersonInfoBuilder<SELF> : PersonBuilder<PersonInfoBuilder<SELF>>
    where SELF : PersonInfoBuilder<SELF>
  {
    public SELF Called(string name)
    {
      person.Name = name;
      return (SELF) this;
    }
  }

  class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
    where SELF : PersonJobBuilder<SELF>
  {
    public SELF WorksAsA(string position)
    {
      person.Position = position;
      return (SELF) this;
    }
  }

  public class BuilderInheritanceDemo
  {
    static void Main(string[] args)
    {
      var builder = new Builder();
      var person = builder.WorksAsA("d").
      Console.WriteLine(person);
    }
  }
}