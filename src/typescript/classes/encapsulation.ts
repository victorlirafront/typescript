export class Person {
    private _name: string;
  
    // CPF é readonly: só pode ser definido na criação e não pode ser alterado depois
    public readonly cpf: string;
  
    constructor(name: string, cpf: string) {
      this._name = name;
      this.cpf = cpf;
    }
  
    public get name(): string {
      return this._name;
    }
  
    public set name(newName: string) {
      if (newName.length > 0) {
        this._name = newName;
      } else {
        console.error("Name must not be empty");
      }
    }
  }
  
  const person = new Person("Victor", "123.456.789-00");
  person.name = "Lira";
