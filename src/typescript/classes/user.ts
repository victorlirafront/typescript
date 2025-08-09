class User {
    private _name: string;
    private _age: number;

    constructor(name: string, age: number) {
        this._name = name;
        this._age = age;
    }

    public get name(): string {
        return this._name;
    }

    public get age(): number {
        return this._age;
    }

    public set age(value: number) {
        if (value < 0) {
            throw new Error("Idade não pode ser negativa");
        }
        this._age = value;
    }
}

// Exemplo de uso
const user = new User("Victor", 28);