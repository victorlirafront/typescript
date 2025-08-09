// Interface que define o formato (contrato) que todo objeto do tipo UserProps deve seguir
export interface UserProps {
  id: string; // Identificador único do usuário
  name: string; // Nome do usuário
  email: string; // Email do usuário
  createdAt: Date; // Data de criação do registro
  updatedAt: Date; // Data da última atualização do registro
}

//Torna todas as propriedades dentro de UserProps opcionais
const createUser = function(user: Partial<UserProps>){
    console.log(user)
}

createUser({});