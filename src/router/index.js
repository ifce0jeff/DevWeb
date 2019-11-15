import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/Login'
import Perfil from '@/components/Perfil'
import Home from '@/components/Home'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Login',
      component: Login
    },
    {
      path: '/Perfil',
      name: 'perfil',
      component: Perfil
    },
    {
      path: '/Home',
      name: 'Home',
      component: Home
    }
  ]
})
