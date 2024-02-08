<template>
    <div v-show="!isEditMode">
        <h1>User profile</h1>
        <img
            src="https://cdn.britannica.com/18/137318-050-29F7072E/rooster-Rhode-Island-Red-roosters-chicken-domestication.jpg">

        <span>Name: </span><b id="name">{{ name }}</b>
        <hr />

        <span>Email: </span><b id="email">{{ email }}</b>
        <hr />

        <span>Interests: </span><b id="interests">{{ interests }}</b>
        <hr />

        <button @click="handleEditProfile">Edit Profile</button>
    </div>
    <div v-show="isEditMode">
        <h1>User profile</h1>
        <img
            src="https://cdn.britannica.com/18/137318-050-29F7072E/rooster-Rhode-Island-Red-roosters-chicken-domestication.jpg">

        <span>Name: </span>
        <input type="text" id="input-name" v-model="name" />
        <hr />

        <span>Email: </span>
        <input type="text" id="input-email" v-model="email" />
        <hr />

        <span>Interests: </span>
        <input type="text" id="input-interests" v-model="interests" />
        <hr />

        <button @click="handleUpdateProfile">Update Profile</button>
    </div>
</template>

<script>
import Button from './Button.vue';
export default {
    name: 'Form',
    data() {
        return {
            name: "",
            email: "",
            interests: "",
            isEditMode: false
        }
    },
    async created() {
        const userData = await this.fetchUserProfile();
        this.name = userData.name;
        this.email = userData.email;
        this.interests = userData.interests;
    },
    components: {
        Button,
    },
    props: {
        title: String,
    },
    methods: {
        handleEditProfile() {
            this.isEditMode = true;
        },

        async handleUpdateProfile() {
            const payload = {
                name: this.name,
                email: this.email,
                interests: this.interests
            }

            const resJson = await this.updateUserProfile(payload);
            console.log(resJson);

            this.isEditMode = false;
        },

        async fetchUserProfile() {
            const res = await fetch('get-profile');
            return await res.json();
        },

        async updateUserProfile(payload) {
            const response = await fetch("update-user-profile", {
                method: "POST",
                headers: {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json'
                },
                body: JSON.stringify(payload),
            });

            return await response.json();
        }
    }
}
</script>

<style>
img {
    width: 320px;
    height: 270px;
    display: block;
    margin-bottom: 40px;
}

div {
    margin: 40px auto;
    width: 80%;
}

hr {
    width: 400px;
    margin: 25px 0;
}

button {
    width: 160px;
    font-size: 15px;
    height: 45px;
    border-radius: 5px;
}

button:hover {
    cursor: pointer;
}

input {
    width: 200px;
    font-size: 15px;
    padding: 10px;
}

#edit-view {
    display: none;
}
</style>