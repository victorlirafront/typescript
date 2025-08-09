// Interface que define o formato (contrato) que todo objeto do tipo UserProps deve seguir
export interface UserProps {
    id: string;         // Identificador único do usuário
    name: string;       // Nome do usuário
    email: string;      // Email do usuário
    createdAt: Date;    // Data de criação do registro
    updatedAt: Date;    // Data da última atualização do registro
  }
  
  // Classe User implementa a interface UserProps,
  // garantindo que todas as propriedades definidas na interface existam na classe com os mesmos tipos
  export class User implements UserProps {
    id: string;
    name: string;
    email: string;
    createdAt: Date;
    updatedAt: Date;
  
    constructor(
      // O parâmetro "props" é o objeto com os dados necessários para criar um usuário.
      // Ele é composto por:
      // - Omit<UserProps, "createdAt" | "updatedAt">
      //   → Copia todas as propriedades de UserProps, exceto "createdAt" e "updatedAt"
      //   → Isso torna "id", "name" e "email" obrigatórios
      //
      // - Partial<Pick<UserProps, "createdAt" | "updatedAt">>
      //   → Pega apenas "createdAt" e "updatedAt" de UserProps (Pick)
      //   → Torna essas propriedades opcionais (Partial)
      //
      // Ao unir os dois (&), o tipo final é:
      // {
      //   id: string;        // obrigatório
      //   name: string;      // obrigatório
      //   email: string;     // obrigatório
      //   createdAt?: Date;  // opcional
      //   updatedAt?: Date;  // opcional
      // }
      props: Omit<UserProps, "createdAt" | "updatedAt"> &
             Partial<Pick<UserProps, "createdAt" | "updatedAt">>
    ) {
      // Define o ID do usuário
      this.id = props.id;
  
      // Define o nome do usuário
      this.name = props.name;
  
      // Salva o email em letras minúsculas para manter consistência
      this.email = props.email.toLowerCase();
  
      // Se "createdAt" não for informado, usa a data/hora atual
      this.createdAt = props.createdAt ?? new Date();
  
      // Se "updatedAt" não for informado, usa a data/hora atual
      this.updatedAt = props.updatedAt ?? new Date();
    }
  }
  