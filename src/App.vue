<template>
  <div id="app">
    <div id="nav">
      <router-link v-if="authenticated" to="/" v-on:click.native="logout()" replace>Logout</router-link>
    </div>
    <router-view  @authenticated="setAuthenticated"/>
  </div>
</template>

<script>
export default {
  name: 'App',
  data() {
    return {
      authenticated: false,
      mockAccount: {
        username: "iesus",
        password: "123"
      }
    }
  },
  methods: {
    setAuthenticated(status) {
      this.authenticated = status;
      console.log('status', status);
    },
    logout() {
      this.authenticated = false;
    }
  }
}
</script>

<style>
</style>
