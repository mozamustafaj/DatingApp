//Interfaces in TS are different to interfaves in C#. We dont need to prefix a TS interface with I (ex Iuser) in the class name
export interface User {
  username: string;
  token: string;
}
