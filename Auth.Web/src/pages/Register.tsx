import React, { useState } from "react";
import { useRegisterMutation } from "../services/api";
import { useNavigate } from "react-router-dom";

function Register() {
    const [username, setUsername] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [registerUser, { isLoading }] = useRegisterMutation();
    const navigate = useNavigate()

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        try {
            await registerUser({ username, email, password }).unwrap();
            navigate('/login')
        } catch {
            alert("Error!");
        }
    };

    return (
        <form onSubmit={handleSubmit} style={{ maxWidth: 320, margin: "auto" }}>
            <h2>Register</h2>

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
                Email:
                <input
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    required
                    autoComplete="email"
                />
            </label>

            <label style={{ marginTop: 12 }}>
                Password:
                <input
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    required
                    autoComplete="new-password"
                />
            </label>

            <button type="submit" disabled={isLoading} style={{ marginTop: 20 }}>
                {isLoading ? "Progress..." : "Register"}
            </button>
        </form>
    );
}

export default Register;
