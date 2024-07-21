import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'BookReview',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44381/',
    redirectUri: baseUrl,
    clientId: 'BookReview_App',
    responseType: 'code',
    scope: 'offline_access BookReview',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44381',
      rootNamespace: 'BookReview',
    },
    BookReview: {
      url: 'https://localhost:44369',
      rootNamespace: 'BookReview',
    },
  },
} as Environment;
