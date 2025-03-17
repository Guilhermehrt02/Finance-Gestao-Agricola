import { Environment } from '@farm/core';

export const environment: Environment = {
  production: true,

  // Google
  clientId: '',
  redirectUri: '',

  // JWT
  jwtToken: 'uNNtAoquY3kUMt1BsvLcUqf51rovyv2e',
  allowedDomains: ['http://localhost:5143'],

  // API URLs
  authApiUrl: 'http://localhost:5143/api/users',
  usersApiUrl: 'http://localhost:5143/api/users',
};
