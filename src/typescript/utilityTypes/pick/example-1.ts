// Defines the shape of a User object
interface User {
    id: string;    // Unique identifier
    name: string;  // User's name
    email: string; // User's email address
  }
  
  // Creates a new type that includes only the "name" and "email" properties from User
  // Pick<Type, Keys> → selects specific properties from a given type
  type onlyNameAndEmail = Pick<User, "name" | "email">;
  