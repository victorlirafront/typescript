function callClass(){
  class User {
    constructor(public id: number, public name: string) {}
  
    greet() {
      return `Hello, ${this.name}`;
    }
  }
  
  const user = new User(1, 'Victor');
  console.log(user.greet());
}

callClass()