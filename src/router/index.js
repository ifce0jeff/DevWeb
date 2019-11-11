import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/Login'
import CadastroUsuario from '@/components/CadastroUsuario'
import Perfil from '@/components/Perfil'
import RecuperarSenha from '@/components/RecuperarSenha'
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
      path: '/CadastroUsuario',
      name: 'CadastroUsuario',
      component: CadastroUsuario
    },
    {
      path: '/Perfil',
      name: 'perfil',
      component: Perfil
    },
    {
      path: '/RecuperarSenha',
      name: 'RecuperarSenha',
      component: RecuperarSenha
    },
    {
      path: '/Home',
      name: 'Home',
      component: Home
    }
  ]
})
