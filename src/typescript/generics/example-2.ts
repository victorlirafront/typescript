// Classe genérica que armazena um valor de qualquer tipo T
class Box<T> {
    private value: T;
  
    constructor(value: T) {
      this.value = value;
    }
  
    getValue(): T {
      return this.value;
    }
  
    setValue(value: T): void {
      this.value = value;
    }
  }
  
  const numberBox = new Box<number>(123);
  console.log(numberBox.getValue()); // 123
  
  const stringBox = new Box<string>("Hello");
  console.log(stringBox.getValue()); // Hello
  