import React, { useState } from "react";
import Cookies from "js-cookie";
import { useLoginMutation } from "../services/api";
import { useNavigate } from "react-router-dom";

function Login() {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const [login, { isLoading }] = useLoginMutation();
    const navigate = useNavigate()

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        try {
            console.log(username, password)
            const result = await login({ username, password }).unwrap();
            Cookies.set("token", result.token, { expires: 1 });
            navigate('/')
        } catch {
            alert("Login error!");
        }
    };

    return (
        <form onSubmit={handleSubmit} style={{ maxWidth: 320, margin: "auto" }}>
            <h2>Login</h2>

            <label>
                Username:
                <input
                    type="text"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    required
                    autoComplete="username"
                />
            </label>

            <label style={{ marginTop: 12 }}>
                Password:
                <input
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    required
                    autoComplete="current-password"
                />
            </label>

            <button type="submit" disabled={isLoading} style={{ marginTop: 20 }}>
                {isLoading ? "Logging in..." : "Login"}
            </button>
        </form>
    );
}

export default Login;
