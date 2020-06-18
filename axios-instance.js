import axios from 'axios'
import Vue from 'vue'
import { store } from '@/store'

const $axios = axios.create()

$axios.CancelToken = axios.CancelToken
$axios.isCancel = axios.isCancel

// We need to intercept the requests and add header (if logged in)
$axios.interceptors.request.use((config) => {
  // Add token if it exists
  const token = store.state.auth.user.token

  if (token) {
    config.headers.Authorization = `Bearer ${token}`
  }

  return config
})

// We also need to intercept the responses to see if we are authorized
$axios.interceptors.response.use(function (response) {
  return response
}, function (error) {
  if (error.response) {
    // Check if 401
    if (window.location.pathname !== '/' && error.response.status === 401) {
      Vue.prototype.$alert({
        title: 'Sessionen slut',
        text: 'Du måste logga in igen',
        type: 'warning',
        confirmButtonText: 'Ok',
        allowOutsideClick: false
      }).then(() => {
        window.location = '/'
      })
    } else if (error.response.status === 403) {
      Vue.prototype.$toast('Du saknar behörighet', 'error', 'exclamation-triangle', true, 5000)
    }

    // Display response data if existing
    if (error.response.data) {
      if (error.response.data.message !== undefined) {
        Vue.prototype.$toast(error.response.data.message, 'error', 'exclamation-triangle', true, 5000)
      } else {
        let allErrors = error.response.data.errors
        for (var i in allErrors) {
          Vue.prototype.$toast(allErrors[i].message, 'error', 'exclamation-triangle', true, 5000)
        }
      }
    }
  }

  return Promise.reject(error)
})

export default $axios
