export interface Environment {
  production: boolean;
  jwtToken: string;
  allowedDomains: string[];
  authApiUrl: string;
  usersApiUrl: string;
}
