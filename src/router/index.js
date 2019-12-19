import Router from 'vue-router';
import Login from '@/views/Login';
import Perfil from '@/views/Perfil';
import Home from '@/views/Home';
import Restaurantes from '@/views/Restaurantes';

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
    },
    {
      path: '/Restaurantes',
      name: 'Restaurantes',
      component: Restaurantes
    },
  ]
});
