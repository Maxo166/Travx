import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import Axios from 'axios' 

import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap" 
 

Axios.defaults.baseURL = process.env.API_ENDPOINT;
                         
createApp(App).use(router).mount('#app')
