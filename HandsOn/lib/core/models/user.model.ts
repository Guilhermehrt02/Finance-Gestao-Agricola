export interface User {
  id?: string;
  firstName: string;
  lastName: string;
  email: string;
  phoneNumber: string;
  role: string | number;
  createdAt?: string;
  updatedAt?: string;
  status?: number;
}
