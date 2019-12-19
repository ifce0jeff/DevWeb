import Vue from 'vue'
import App from './App'
import router from './router'
import BootstrapVue from 'bootstrap-vue'

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import VueRouter from 'vue-router';
import feather from 'vue-icon'


Vue.use(BootstrapVue)
Vue.use(VueRouter)
Vue.config.productionTip = false
Vue.use(feather, 'v-icon')

new Vue({
  render: h => h(App),
  router: router,
}).$mount("#app");
