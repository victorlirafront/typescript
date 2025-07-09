// Original type
type User = {
    id: number;
    name: string;
    email: string;
  };
  
  //Partial<T> é um utilitário do TypeScript que transforma todas as propriedades de um tipo em opcionais.
  function updateUser(user: User, updates: Partial<User>): User {
    return {
      ...user,
      ...updates,
    };
  }
  
  // Example usage
  const user: User = {
    id: 1,
    name: "Victor",
    email: "victor@email.com",
  };
  
  // Updating only the name (note that we don't need to pass all fields)
  const updatedUser = updateUser(user, {
    name: "Victor Lira",
  });
  
  console.log(updatedUser);
  /*
  Output:
  {
    id: 1,
    name: "Victor Lira",
    email: "victor@email.com"
  }
  */
  