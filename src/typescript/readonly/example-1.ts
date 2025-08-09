// Como funciona?
// Quando você usa Readonly<User>, o TypeScript cria um novo tipo igual a User, só que com todas as 
// propriedades marcadas como readonly.
// Isso significa que você pode ler as propriedades, mas não pode alterá-las.


export interface User {
    id: string;
    name: string;
  }
  
  // Torna todas as propriedades de User readonly
  type ReadonlyUser = Readonly<User>;
  
  const user: ReadonlyUser = {
    id: "123",
    name: "Victor",
  };
  
  //user.id = "456"; // ❌ Erro: Cannot assign to 'id' because it is a read-only property.
  