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

    <div id="sld"></div>

    <div>
      <h1 class="primeiro">Bem Vindo ao</h1>
      <h1 class="segundo">Baratiê</h1>
      <hr class="b-hori">
      <p class="parag">
        Somos um novo nome, mais restaurantes, melhores benefícios
        e o mesmo amor pela comida! O Baratiê vai te ajudar na hora de fazer aquela
        reserva no restaurante que você tanto gosta. Sem burocracia,
        rapido, pratico e eficiente! Tudo para que você desfrute do melhor.
      </p>
    </div>
    <button class="botao-res" id="log" type="button">Faça Sua Reserva</button>
    
  </div>
</body>
</template>

<script>
</script>

<style scoped>
#sld {
filter: brightness(38%);
position: relative;
width: 100%;
height: 100vh;
background-position: center center;
background-size: cover;
background-repeat: no-repeat;
backface-visibility: hidden;
animation: sld 15s linear infinite 0s;
animation-timing-function: ease-in-out;
background-image: url(../assets/1.jpg);
}

@keyframes sld {

  0% {
    background-image: url(../assets/2.jpg)
  }

  25% {
    background-image: url(../assets/3.jpg)
  }

  50% {
    background-image: url(../assets/4.jpg)
  }
  
  75% {
    background-image: url(../assets/5.jpg)
  }
  
  100% {
    background-image: url(../assets/6.jpg)
  }
  
}

h3 {
  color: aliceblue;
}
.imgpos {
  position: relative;
  top: 80 px;
  left: 100 px;
}
#container {
  display: inline-block;
  position: relative;
}
#container figcaption {
  position: absolute;
  top: 190px;
  right: 200px;
  font-size: 60px;
  color: rgb(210, 227, 230);
  text-shadow: 0px 0px 5px black;
}
.primeiro {
  position: absolute;
  top: 160px;
  left: 312px;
  color: rgb(255, 255, 255);
  font-family:Georgia, 'Times New Roman', Times, serif;
  font-size: 75px;
}
.segundo {
  position: absolute;
  top: 160px;
  left: 798px;
  color: #0c75ee;
  font-style: italic;
  font-family:Georgia, 'Times New Roman', Times, serif;
  font-size: 75px;
}

.parag {
  font-size: 130%;
  position: absolute;
  top: 310px;
  left: 150px;
  margin-right: 12%;
  color: white;
  font-family:Georgia, 'Times New Roman', Times, serif;
  text-align: center;
}

.b-hori {
  height: 50px;
  border: none;
  color: rgb(255, 255, 255);
  margin-top: 40px;
  margin-right: 60%;
  margin-bottom: 0px;
  position: absolute;
  left: 52px;
  top: 50%;
}

.botao-res {
  position: absolute;
  border: 0;
  background: rgb(10, 25, 231);
  margin: 10px auto;
  text-align: center;
  color: white;
  border: 1.5px solid rgb(123, 146, 248);
  padding: 9px 30px;
  outline: none;
  transition: 0.39s;
  font-size: 14px;
  border-radius: 5px;
  cursor: pointer;
  top: 480px;
  left: 880px;
}

li {
  margin-right: 40px;
}
</style>