<template>
<body>
  <div>
    <nav class="navbar navbar-expand-sm bg-primary navbar-dark fixed-top">
      <a class="navbar-brand" href="#">
        <img src="../assets/logologin.png" alt="logo" style="width:48px;" />
      </a>

      <ul class="navbar-nav">
        <li class="nav-item">
          <h3>Baratiê</h3>
        </li>
        <li class="nav-item">
          <router-link to="/Home">
            <span class="nav-link">Inicio</span>
          </router-link>
        </li>
        <li class="nav-item">
          <router-link to="/Restaurantes">
            <span class="nav-link">Restaurantes</span>
          </router-link>
        </li>
        <li class="nav-item">
          <router-link to="/Perfil">
            <span class="nav-link">Seu Perfil</span>
          </router-link>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sobre</a>
        </li>
        <li class="nav-item">
          <router-link to="/">
            <span class="nav-link">Sair</span>
          </router-link>
        </li>
      </ul>
    </nav>
  <br>
  <br>
  <br>
  <div class="header">
    <img class="fundoavatar" src="https://cdn.pixabay.com/photo/2015/09/17/10/31/banner-943868_960_720.jpg">
    <img class="avatar" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQAq-kDuBVISjGySzX1pIu93Btb8tRboFFTeyQyBQhVS1bt9h6kw&s" />
    <div class="teste">
    <h1 class="userName">{{ usuario.nome }}</h1>

    <ul class="lista">
      <li>
        <i class="icone email"></i>
        <a href="mailto:teste@gmail.com">{{ usuario.email }}</a>
      </li>
      <li>
         <i class="icone facebook"></i>
        <a href="http://facebook.com/teste">{{ usuario.facebook }}</a>
      </li>
      <li v-if="usuario.twitter != null">
         <i class="icone twitter"></i>
        <a href="http://twitter.com/teste">{{ usuario.twitter }}</a>
      </li>
    </ul>

    <div class="sobre">
      <h2>Sobre</h2>
      <p>{{ usuario.sobre }}</p>
    </div>
    </div>

  </div>

  </div>
</body>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      usuario: {},
    }
  },
  created() {
    axios.get('http://localhost:3000/usuarios')
    .then(response => {
      this.usuario = response.data[0]
      console.log(this.usuario);
    })
    .catch(e => {
      this.errors.push(e)
    })
  }
}
</script>

<style scoped>

.teste {
  position: relative;
  top: 85%;
}

.icone {
  width: 16px;
  height: 16px;
  display: inline-block;
  background-size: cover;
}

.email {
  background-image: url("data:image/png;base64,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")
}

.facebook {
  background-image: url("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAaVBMVEVIWpb///80So7s7fNCVZR7hq9GWJVOX5nz9PhfbaE3TY9AVJM5TpDX2uVRYprQ0+FwfKlYZ52bo8GzuM8uRozj5e3IzNy9wtWsssuRmruDjbOgp8Tw8fXa3eelrMeHkbZmdKRteqgYN4aJcfDyAAAD4UlEQVR4nO3dbXOiMBSG4UDZFJPIa9DWRdvu//+Ri1JnutNZGsXknGSe+0s/leEahCABFNlndddUIpWqpquvMDH/6bXSUlKv2MOScvL0X4Rja6jXyUOmHa/CQRXUa+MlqYZZOKp0Pp7/JtV4EbZpbsFzRXsW9inug9dMPwk19Vp4TWeiVtQr4TVViy7xbdiJJtUD6ZxsRJW4MJ1TUYQQQgghhBBCCCGE7kwW2qg8z22upj/W5peUUsZorYsi7muEUitbHU777VBmXyrHp+FY7/b9qXtrNsXkjZNZGPt+2mYOlUOMW1LbZl/+jPssuolBaeSLOy9Coar2t/CiE+riVl9cQmm7m31RCfXzcAcwIqE63OOLSGhf7gNGI7S7O4GxCG39MyVq4QpgHML89lEwLqG5ZxiMSVi8rwFGIJTqphPtCIX53eNEJMKiWQfkL7RPiQv160oge6Fdd5jhL1y/CbkLV++F3IWrD6TshWblWMheKNV6IG9h8Za68BEfUt7C9YMhc6HcPADIWqhv/OZbDsftt46cn5m8ZTfcvW7mydFvMQaK3PWEZjhYozlL/lfuCOws531tIdcDzXu0zw46jvcf8T53pn+7APuIHx00vYswj/EI85nTYBH1A7zK5XaSTcSbUKijg9BSr+WacodJ7W3Exxm3U5qod0Mn4e94B0PhJnxNXniI9Ix0zkX4C0LWQQgh/yCEkH8QQsg/CCHkH4QQ8g9CCPmXhlAu5CTUS0uQDO5SeF7IuAgXlzBF/E7Ex9wws9iYpy4kfrtsAOGeduomgJB46iaAkHhiI4CQeBY8gNCkLixpB4sAwoF4nt+/cEc8z+9f2BPPgvsXUr9O3r+Q+tuVf2FL/PXJv5B4sPAvpB4O/QuP1Le9eRdSD4f+hS/UN4V5F5Lf9uZd2FBfbPQufKa+muhdSH6PtG/hE/Vw6F1Ifxe4byHxpcQAwhP1YOFd+Ja88IN6sPAupB7v/QvJh0PfQvrh0LeQwe82TsJyIQfE0r+X1JcSL8R8oT8Os9yNXVgAA+ByadyLsRSEEPIPQgj5ByGE/IMQQv5BCCH/IISQfxBCyD8IIeQfhBDyD0II+QchhPyDEEL+QQgh/yCEkH8QQsg/CCHkH4QQ8g9CCPkHIYT8gxBC/kEIIf8ghJB/EELIPwgh5F9AYUXzIptQQlmJJnFhI4hexhtKqDtB9J6XUEJViyzxbZgJot/3DiQ0/STMWophJ4ywaLOzcFQEh9MgQqnGizAbVPitGEJYqCGbhdnYBt8XAwhNO2ZX4fkl/EoH/YUov0IpJ08/L0VcF1d3TcgfiPIrrJquvi7lL/eDSV3Karp8AAAAAElFTkSuQmCC")
}

.twitter {
  background-image: url("data:image/png;base64,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")
}

.sobre {
  padding: 10px;
}

.sobre h2 {
  font-size: 16px;
}

  .about p {
    font-size-adjust: 14px;
  }

a{
  text-decoration: none;
  color: blue;
}

a:hover {
  color: aquamarine;
}

.lista {
  list-style: none;
  text-align: center;
  padding: 0;
}

.lista li {
  display: inline-block;
  margin: 5px;
}

.header {
  text-align: center;
  height: 250px;
  padding: 12px;
}

.avatar {
  position: absolute;
  width: 200px;
  height: 200px;
  border-radius: 50%;
  left: 585px;

}

.fundoavatar {
  top: 79px;
  right: 0px;
  height: 235px;
  width: 100%;
  position: absolute;
}
.userName {
  font-size: 20px;
  margin-top: 14px;
  color: white;
}

h3 {
  color: aliceblue;
}

li {
  margin-right: 40px;
}
</style>