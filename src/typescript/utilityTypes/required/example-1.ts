export interface User {
    id: string;
    name?: string;  // Opcional
    email?: string; // Opcional
  }
  
  // Com Required, todas ficam obrigatórias
  type UserComplete = Required<User>;
  
  const user1: UserComplete = {
    id: "123",
    name: "Victor",     // Agora obrigatório
    email: "v@ex.com"   // Agora obrigatório
  };
  