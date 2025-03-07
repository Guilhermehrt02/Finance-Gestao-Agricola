export const environments: Environments = {
  // Google Auth
  googleClientId: '',
  googleRedirectUri: '',

  // JWT
  jwtToken: 'uNNtAoquY3kUMt1BsvLcUqf51rovyv2e',
  jwtDomain: 'http://localhost:5143',

  // API URLS
  authenticationApi: 'http://localhost:5143/api/users',
  usersApi: 'http://localhost:5143/api/users',

  // Third Party APIs
};

export interface Environments {
  googleClientId: string;
  googleRedirectUri: string;
  jwtToken: string;
  jwtDomain: string;
  authenticationApi: string;
  usersApi: string;
}
