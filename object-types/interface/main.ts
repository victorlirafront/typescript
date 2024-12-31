function callInterface(){
  interface User {
    id: number;
    name: string;
  }
  
  interface Admin extends User {
    permissions: string[];
  }
  
  const admin: Admin = { id: 1, name: 'Victor', permissions: ['read', 'write'] };  
  console.log(admin)
}

callInterface();