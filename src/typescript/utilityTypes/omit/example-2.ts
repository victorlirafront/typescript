export type User = {
    id: string;
    name: string;
    email: string;
    createdAt:  Date;
}

//Tornando o createdAt opcional para o parâmetro dessa função
function createUser(user: Omit<User, 'createdAt'> & Partial<Pick<User, 'createdAt'>>){
    console.log(user)
}

createUser({
    id: "1sfsd",
    name: "Victor",
    email: "victorlira@gmail.com",
});