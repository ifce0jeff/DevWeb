<template>
  <div>
    <nav class="navbar navbar-expand-sm bg-primary navbar-dark fixed-top">
      <a class="navbar-brand" href="#">
        <img src="../assets/logo.png" alt="logo" style="width:40px;" />
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
          <a class="nav-link" href="#">Reserva</a>
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
    <div>
      <table style="margin-top: 100px">
        <thead>
          <tr>
            <th v-for="(i, id) in headerItens" :key="id">{{ i.header }}</th>
          </tr>
        </thead>
        <tbody v-model="items">
          <tr v-for="(e, id) in items" :key="id">
            <td>{{ e.Nome }}</td>
            <td>{{ e.Endereço }}</td>
            <td class="money">
              <div style="display: inline" v-for="(i, id) in e.Preço" :key="id">$</div>
            </td>
            <td>
              <v-icon v-for="(i, id) in e.Categoria" :key="id" class="star" name="star"></v-icon>
            </td>
            <td>{{ e.Especialidade }}</td>
            <td>{{ e.Status }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      headerItens: [
        // { header: "" },
        { header: "Nome" },
        { header: "Endereço" },
        { header: "Preço" },
        { header: "Categoria" },
        { header: "Especialidade" },
        { header: "" }
      ],
      items: [
        {
          Logo: "../assets/Restaurantes/mcdonalds.png",
          Nome: "McDonald",
          Endereço: "Macdonald",
          Preço: 1,
          Categoria: 2,
          Especialidade: "Laches",
          Status: "Aberto"
        },
        {
          Logo: "../assets/Restaurantes/laparrilla.png",
          Nome: "Laparrilla",
          Endereço: "Shaw",
          Preço: 2,
          Categoria: 1,
          Especialidade: "Hamburguer",
          Status: "Fechado"
        },
        {
          Logo: "../assets/Restaurantes/point.png",
          Nome: "Point Certo",
          Endereço: "Wilson",
          Preço: 3,
          Categoria: 3,
          Especialidade: "Pizza",
          Status: "Fechado"
        },
        {
          Logo: "../assets/Restaurantes/bobs.jpg",
          Nome: "Bob's",
          Endereço: "Carney",
          Preço: 4,
          Categoria: 4,
          Especialidade: "Lanches",
          Status: "Aberto"
        },
        {
          Logo: "../assets/Restaurantes/mcdonalds.png",
          Nome: "Pizzaria Napolitana",
          Endereço: "Rua Dragão do Mar",
          Preço: 1,
          Categoria: 3,
          Especialidade: "Pizza",
          Status: "Aberto"
        },
        {
          Logo: "../assets/Restaurantes/mcdonalds.png",
          Nome: "Jião Huò",
          Endereço: "Rua Carvalho",
          Preço: 3,
          Categoria: 4,
          Especialidade: "Chinesa",
          Status: "Aberto"
        },
        {
          Logo: "../assets/Restaurantes/mcdonalds.png",
          Nome: "Trip Burger",
          Endereço: "Rua Barão",
          Preço: 3,
          Categoria: 4,
          Especialidade: "Laches",
          Status: "Aberto"
        }
      ]
    };
  }
};
</script>

<style scoped>
table {
  box-shadow: 2px 2px 7px 3px rgb(150, 150, 150);
  margin: 15px;
  width: 75%;
  /* text-align: center; */
  overflow: hidden;
  /* border-collapse: separate; */
  border: solid rgb(150, 150, 150) 1px;
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  border-radius: 5px;
  margin: auto;
}

table thead {
  border-collapse: collapse;
}

table td {
  color: #aaa;
  background-color: white;
  padding: 5px;
  border: 1px solid #ddd;
}

.star {
  width: 20px;
  color: rgb(236, 213, 0);
}

.money {
  font-weight: bold;
  font-style: italic;
  color: rgb(0, 180, 0);
}
</style>