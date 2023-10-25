<script lang="ts">
    import { onMount } from 'svelte'
    const apiUrl: string = 'http://localhost:5005/api'
    let weatherForecastData: string | undefined = undefined

    onMount(async () => {
        const res = await fetch(`${apiUrl}/weatherforecast`)
        weatherForecastData = await res.text()
    })
</script>

<div>
    {#if weatherForecastData === undefined}np
        <p>Loading...</p>
    {:else}
        <span>Hello from API: {weatherForecastData}</span>
    {/if}
</div>
