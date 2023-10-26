<script lang="ts">
    import { onMount } from 'svelte'
    const apiUrl: string = 'http://localhost:5005/api'
    let weatherForecastData: string | undefined = undefined

    onMount(async () => {
        const res = await fetch(`${apiUrl}/weatherforecast`)
        weatherForecastData = await res.text()
    })
</script>

<div class="flex text-read-white w-1/2 text-center mx-auto items-center">
    <div role="status" class="mx-auto h-12 text-center">
        {#if weatherForecastData === undefined}
            <p>Loading...</p>
        {:else}
            <p class="w-max">Hello from API: {weatherForecastData}</p>
        {/if}
    </div>
</div>
