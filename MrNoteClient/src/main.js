import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import { router } from './router'
// import '@mdi/font/css/materialdesignicons.css'

const root = createApp(App)
registerGlobalComponents(root)


root
  .use(router)
  .mount('#app')




